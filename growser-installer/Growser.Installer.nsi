Function CheckDotNetFramework

  /* Exchange $R0 with the top of the stack to get the value passed by caller */
  Exch $R0

  /* Save other NSIS registers */
  Push $R1
  Push $R2
  Push $R3

  /* Zero out $R2 for the indexer */
  StrCpy $R2 "0"

loop:
  /* Get each sub key under "SOFTWARE\Microsoft\NET Framework Setup\NDP" */
  EnumRegKey $R1 HKLM "SOFTWARE\Microsoft\NET Framework Setup\NDP" $R3
  StrCmp $R1 "" version_not_found  /* Requested version is not found */

  StrCpy $R2 $R1 "" 1              /* Remove "v" from subkey */
  StrCmp $R2 $R0 version_found     /* Requested version is found */

  IntOp $R3 $R3 + 1                /* Increment registry key index */
  Goto loop

/* The requested .Net Framework version WAS NOT FOUND on this system */
version_not_found:
  /* Restore the registers saved earlier */
  Pop $R3
  Pop $R2
  Pop $R1
  Pop $R0

  Push "1"  /* Put "1" on the top of the stack for caller to use */
  Goto end

/* The requested .Net Framework version WAS FOUND on this system */
version_found:
  /* Restore the registers saved earlier */
  Pop $R3
  Pop $R2
  Pop $R1
  Pop $R0

  Push "0"  /* Put "0" on the top of the stack for caller to use */

end:

FunctionEnd
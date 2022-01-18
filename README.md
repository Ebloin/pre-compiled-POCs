## 1. CreateAdmin-exe-POC
An executable that if launched creates a new local Administrator (*LocalAdminPrivEsc:Priv3scPOC!*) and outputs to a file in "*C:\\Users\Public\LocalAdmin-POC.txt*"

## 2. Whoami-exe-POC
An executable that executes command *whoami* and outputs to "*C:\\\\Users\\Public\\POC.txt*"

## 3. Exploiting-DLL-Search-Order-Hijacking
A DLL that if called through *LoadLibrary* executes command *whoami* and outputs to "*C:\\\\Users\\Public\\POC.txt*"

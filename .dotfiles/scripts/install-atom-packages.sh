# This install all Atom packages found in the atom-package.list onto local Atom

echo '>>> Running script to install all packages from ~/.atom/package.list... :) '
apm install --packages-file ~/.atom/package.list

echo 'DONE! YOU DID IT!'

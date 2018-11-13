# This is used to save the Atom packages to a file

echo 'Getting packages from local Atom, and saving them to ~/.atom/package.list'
apm list --installed --bare > ~/.atom/package.list

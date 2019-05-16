# This is used to save the Atom packages to a file

echo 'Getting packages from local Atom, and saving them to ~/.atom/package.list'
# apm list --installed --bare > ~/.atom/package.list

# This supposably filters the version info
apm list --installed --bare | grep '^[^@]\+' -o > ~/.atom/package.list

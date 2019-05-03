# Programming Cheat Sheet

this is my super handy cheat sheet with commands I keep forgetting, or just stuff I'm learning :D

## Bash/ZSH

`netstat -aon | findstr port_number`
  - find the PID of a process running on port_number

- Bash basics

`mkdir`	-create directory
`cd` -change directory, go to that folder
`cp` -copy file. (Ex: `cp file1.txt file2.txt`)
`ls` - list everything inside your current folder
`pwd`	- print working directory (show where you are right now)
`nano`	-text editor
`pico` - another text editor?
`man` - open manual
`man` [what you want] - open that manual


`chmod 644` - change permission.
`chmod +x ‘filename.sh’`
  - allows all permissions, creates executable .sh file
`chmod 744 filename.sh`
  - allows .sh file to be executable
`wc filename.txt` -lines, word count, bytes
`cat. users.txt | grep -n lgc13` - (grep -n looks for line where the following word is at)
q -exit manual, others
man g++ - manual for compiler
g++ -compile file
g++ -o	-compile file to the extension of:
make -compile it automatically
ls *_filetype -shows all files with ‘_filetype’ at the end of their name
rm - remove file
rm *_filetype -rms all files with '_filetype’ at the end of their name
mv -rename file
clear -clears window
./filename -run file
touch -create blank file that doesn’t yet exist
brew doctor - open brew
update brew ==
pwd -present working directory
cd .. -go back one folder
(in home directory) atom .bash_profile -opens that <<
sudo passwd user_name - change password
for that user
sudo adduser user_name - add user
sudo gpasswd-a user_name sudo -make
user an admin
tar -xf file_name.tar.gz - extract files
chown -R `whoami`:staff
(In term2) prompt -l
- lists the type of fonts available
prompt -p type
- try this one
prompt -s type
- activate this one
grep -win -B 4 “some text” ./*
- w (whole words)
- i (not case sensitive, looks for upper and lowercase)
- n (found in ’n’ line number)
- B 4 (shows 4 lines before text found)
grep -winr “some text” .
- r (looks within the entire directory, RECURSIVELY)
  ​

# Programming Cheat Sheet

this is my super handy cheat sheet with commands I keep forgetting, or just stuff I'm learning :D

## Bash/ZSH

- Bash basics
```sh
mkdir	# create directory
cd    # change directory, go to that folder
cd .. # go back one directory
cp    # copy file. (Ex: `cp file1.txt file2.txt`)
ls    # list everything inside your current folder
ls *.py # shows all files with .py in the end
rm    # remove file
pwd	  # print working directory (show where you are right now)
mv    # rename file
clear # clears window
./filename # run file (must be executable)
man   # open manual
man some_command # open that manual
```

- File manipulation
```sh
vim     # text editor
nano    # text editor
pico    # another text editor?
touch   # create blank file that doesn’t yet exist
wc filename.txt                 # lines, word count, bytes
cat. users.txt | grep -n lgc13  # (grep -n looks for line where the following word is at)
tar -xf file_name.tar.gz        # extract files
grep -winr “some text” .        # r (looks within the entire directory, RECURSIVELY)
grep -win -B 4 “some text” ./*  # w: whole words| i: not case sensitive| n: line number 
  # B 4: shows 4 lines before text is found
```

- Permission
```sh
chmod 644 filename.sh   # change permission.
chmod +x filename.sh    # allows all permissions, creates executable .sh file
chmod 744 filename.sh   # allows .sh file to be executable
chown -R `whoami`:staff
```

- Processes
```sh
netstat -aon | findstr port_number  # find the PID of a process running on port_number
kill -9 pid_number  # kills process running with pid_number
```

## Git

- Git basics
```sh
git add
git status
git commit -m “message here” # commits with message
git push
git remote -v # show origin/master. Can also click the config folder in .git folder

```

- Branches
```sh
git branch -a                # list all branches, local and remote
git branch -d branch name    # deletes branch locally.
  # use `-D` to force delete the branch
git branch -m new-name       # renames local branch name
git checkout -b branchName   # creates a branch and checks out to it
git push origin --delete branch_name # deletes remote branch
```

- Advanced

```sh
git fetch —all —prune    # fetches origin, and prunes local comparing to it
git log                  # find previous commits and their commit_id s
git revert commit_id     # revert changes made by that commit_id
git merge —abort         # aborts the merge (which has conflicts)
git checkout origin/master filename # reverts file back to how it is in master
```

## Vim

- You can make permanent changes to your VIM editor by changing ~/vimrc

- Vim basics:
```sh
vim filename.txt    # opens file in vim editor from bash/terminal
i	  # enters insert mode
A	  # enters insert mode at the end of the line
‘ESC’ # gets out of insert mode
:     # to write cmd
:w    # to write
:q    # to quit
:q!   # quit without saving
```

- Moving around file
```sh
w   # jumps to beginning of next word
b	  # move to beginning of previous word
0	  # move to start of line
$	  # move to end of line
Shift + V # highlights entire line
y	  # copies anything highlighted
Shift + p # pastes
```

- Making life easier
```sh
:set number   # show line numbers
:syntax on    # turn syntax highlighting on
:set hlsearch # highlights searches
```

### iTerm2

```sh
prompt -l       # lists the type of fonts available
prompt -p type  # try this one
prompt -s type  # activate this one
````

### Brew

```sh
brew doctor # open brew
update brew # updates brew
```

### C++

```c++
g++ // compile file
g++ -o	// compile file to the extension of:
make // compile it automatically
```

### C#

- Running a C# app

1. Install Mono
2. `mcs filename.cs` - compiles file
3. `mono filename.ext` - executes file

```c#
default:
  using System;
    public class program_name;
    {
      static public void Main() {
        Console.Write("Hello World");
      }
    }
```

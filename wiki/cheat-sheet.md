# Programming Cheat Sheet

this is my super handy cheat sheet with commands I keep forgetting, or just stuff I'm learning :D

## Bash/ZSH

- Bash basics

```sh
mkdir	# create directory
cd # change directory, go to that folder
cd .. # go back one directory
cp # copy file. (Ex: `cp file1.txt file2.txt`)
ls # list everything inside your current folder
ls *.py # shows all files with .py in the end
rm # remove file
pwd	# print working directory (show where you are right now)
mv # rename file
clear # clears window
./filename # run file (must be executable)
man # open manual
man some_command # open that manual


```

- Files manipulation

```sh
vim # text editor
nano # text editor
pico # another text editor?
touch # create blank file that doesn’t yet exist
wc filename.txt # lines, word count, bytes
cat. users.txt | grep -n lgc13 # (grep -n looks for line where the following word is at)
tar -xf file_name.tar.gz # extract files
grep -win -B 4 “some text” ./*
:'
- w (whole words)
- i (not case sensitive, looks for upper and lowercase)
- n (found in ’n’ line number)
- B 4 (shows 4 lines before text found)
'
grep -winr “some text” . # r (looks within the entire directory, RECURSIVELY)
```

- Permission

```sh
chmod 644 filename.sh # change permission.
chmod +x filename.sh # allows all permissions, creates executable .sh file
chmod 744 filename.sh # allows .sh file to be executable
chown -R `whoami`:staff
```

- Processes

```sh

netstat -aon | findstr port_number # find the PID of a process running on port_number
```


## C++

```c++
g++ // compile file
g++ -o	// compile file to the extension of:
make // compile it automatically
```

### iTerm2

```sh
prompt -l # lists the type of fonts available
prompt -p type # try this one
prompt -s type # activate this one
````


### Brew

```sh
brew doctor # open brew
update brew # updates brew

```




  ​

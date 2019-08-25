# Programming Cheat Sheet

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

ls -l | grep -v ^l | wc -l      # counts how many files in current directory
```

- Permission
```sh
chmod 644 filename.sh   # change permission.
chmod +x filename.sh    # allows all permissions, creates executable .sh file
chmod 744 filename.sh   # allows .sh file to be executable
chown -R `whoami`:staff

stat -f "%A %a %N" filename.sh # find file permission in octal notation. eg: 644, 755
```

- Processes
```sh
# MacOS terminal
lsof -i:portNumber # find process running on portNumber
kill -9 pid_number  # kills process running with pid_number

# Fow Windows cmd shell, run the following:
netstat -aon | findstr portNumber  # find the PID of a process running on portNumber
taskkill /PID typeyourPIDhere /F # kill that process
taskkill //PID typeyourPIDhere //F # for BASH on Windows
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

- You can make permanent changes to your VIM editor by changing ~/.vimrc

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

## MySQL

To login MYSQL from terminal: `mysql -u username -ppassword`

- MySQL basics
```sql
SHOW DATABASES; -- shows all databases
CREATE DATABASE databasename; -- creates the DB
CREATE DATABASE IF NOT EXISTS databasename; -- does at it says
USE database name; -- selects that db
SHOW TABLES -- shows tables in that db
SELECT * FROM tablename; -- shows everything in that table
```

- User and privileges
```sql
CREATE USER username identified by 'passwordhere'; --does as it says
SELECT User FROM mysql.user; -- lists all users
SELECT user, host, WHATEVER; -- shows the user, host, or whatever you put here
CREATE USER newuser'@'localhost IDENTIFIED BY 'password'; -- creates new user
GRANT ALL PRIVILEGES ON * . * TO newuser@localhost; -- give all permissions to user
```

## PostgreSQL/ PSQL

```sql
\l    -- lists all databases
:\q   -- exits (END)/quits anything you’re in
\dn   -- shows all schemas
\c database_name -- connects to a database_name
\dt   -- show all tables
\du   -- show users
\conninfo -- shows connection info like db name, username name, and port
CREATE DATABASE db_name; -- creates a db_name
CREATE TABLE table_name(col_1 type, col2 type(number)); -- creates a table
SERIAL PRIMARY KEY -- SERIAL makes it auto increment
SELECT * FROM table_name; -- displays everything from a table
INSERT INTO table_name VALUES (info, info); -- insert a single row with all values from cols
UPDATE table_name SET col_name = new_value WHERE col_name = current_value;
-- update row value
ALTER TABLE table_name ADD COLUMN new_col new_col_type
-- add col to table
UPDATE table_name SET col_name = ‘new_value’
WHERE other_col IN (‘row1_value’, ‘row2_value’);
-- update multiple rows (from a single row query)
DELETE FROM table1 WHERE name = 'chris'
AND age = 24 AND sex = 'F' AND happy = 'M';
-- delete row depending on many col_values
SOURCE ~/location_of/file_name.sql -- import file into database

-- Sequences
SELECT * FROM information_schema.sequences; -- shows all sequences in a database

create sequence IF not exists schemaName.sequenceName_id_seq
OWNED BY schemaName.tableName.colName; -- does as it says

SELECT currval('schemaName.sequenceName_id_seq'); -- displays sequence current value
SELECT nextval('schemaName.sequenceName_id_seq'); -- displays sequence next value
SELECT setval('schemaName.sequenceName_id_seq', 3, true); -- sets sequence value to 3, next value will be 4

```

### AWS CLI

```sh
aws s3 ls s3://bucket-name/ # List S3
aws s3 cp s3://path_to_file - # displays file in terminal
aws s3 cp s3://path_to_file ~/some/local/path  # copies file to some/local/path
aws s3 cp s3://path_to_directory s3://some/other/directory --recursive  # copies entire directory to s3://some/other/directory
aws s3 rm s3://path-to-directory/ —-recursive # deletes entire folder
​
```

   * Using different profiles

     1. In `~/.aws/`, create (if it doesn't already exist) a `credentials` file
     2. Add any profiles that you want as such:

     ```sh
     [default]
     aws_access_key_id = some-key
     aws_secret_access_key = some-secret-access-key

     [stg]
     aws_access_key_id = some-key
     aws_secret_access_key = some-secret-access-key

     [prod]
     aws_access_key_id = some-key
     aws_secret_access_key = some-secret-access-key
     ```

     3. (I'm no sure if this step is needed) Create a `config` file and add any other parameters you need there:

     ```sh
     [default]
     region = us-east-1

     [profile stg]
     region = us-east-1

     [profile prod]
     region = us-east-1
     ```
  Now you can see different buckets:

  ```sh
  aws s3 ls s3://dev-bucket-name/               # List default S3
  aws s3 ls s3://stg-bucket-name/ --profile stg # List stg S3
  aws s3 ls s3://prd-bucket-name/ --profile prd # List prd S3
  ```

### Pipenv

Links to useful guides:
https://realpython.com/pipenv-guide/

```sh
pipenv install # looks for ‘pipfile’ and ‘pipfile.lock’, then installs those dependencies
pipenv install some_dependency # installs some_dependency
  # Dependencies example: flask, request, flask-SQLAlchemy
pipenv shell  # opens shell in the environment created
pipenv graph  # lists dependencies being used
pipenv —vena  # shows directory of virtualenv saved
pipenv —rm    # removes current project environment
exit          # gets out of environment
```

### Docker

```sh
docker ps # Checks instances running
docker container ls -a # Find all container instances (running and not running)

docker start instance_name # start instance
docker container start container_id # start a Docker container
docker stop container_id # Stop instance running

docker pull microsoft/mssql-server-linux # Installing SQL Server
```

### Brew

```sh
brew doctor # open brew
update brew # updates brew
```

### Yarn

- Installing on Windows:

1. Get Node.js
https://nodejs.org/en/
2. Install Yarn package
https://yarnpkg.com/latest.msi


### SDK Man

All info found here (Favorite on Chrome):
https://sdkman.io/usage

```sh
# List all installed by tech
sdk list techName # ex: sdk list java

sdk install techName versionNumber # ex: sdk install java 7.0.222-zulu
```

### iTerm2

```sh
prompt -l       # lists the type of fonts available
prompt -p type  # try this one
prompt -s type  # activate this one
````

### IntelliJ Shortcuts

```sh
CMD + O # find class
CMD + SHIFT + O # find file
CMD + SHIFT + F # find globally
CMD + SHIFT - OR + # collapses/expands everything collapsable
CMD + SHIFT + T # goes between test file and file being tested
```
​
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

```cs
default:
  using System;
    public class program_name;
    {
      static public void Main() {
        Console.Write("Hello World");
      }
    }
```

### Setting up new Mac terminal environment

1- install iterm2

2- Install zsh

  https://www.smashingmagazine.com/2015/07/become-command-line-power-user-oh-my-zsh-z/

  2.1 - change shell to zsh

3- Get Cobalt2

https://medium.com/@jcmadrigalg/how-to-install-the-cobalt2-theme-for-iterm2-89e2cb396afa

  3.1 - Clone this repo

  https://github.com/wesbos/Cobalt2-iterm

4- Install hexa

  4.1- Add this to `~/.bash_profile` once exa has been installed:

  `alias ls='exa --long --header --git -TL 1'`

5- Install Atom, an IDE,

- Personal preferences:

   - Turn off Mojave Dock recent applications:

   Settings > Dock > 'Show recent applications in Dock'

### VS Code settings

I. Install One Dark Pro Theme

II. Set up eslint for VS code:

  1. Create a `.eslintrc` file in your project directory

  2. Add rules found in [this file](/react/eslintrc-to-copy-from)

III. Add the dependencies

  1. Go to your package.json and [these](/react/package-json-to-copy-from)

IV. Get Eslint extension

  1. Add the Eslint extension from the marketplace (for Visual Studio)

  2. Add the following to your VS Code user settings.json:
  (User settings file is saved under `~/Library/Application Support/Code/User/settings.json`)

  ```json
  {
      "workbench.colorTheme": "One Dark Pro",
      "workbench.tree.indent": 20,
      "window.zoomLevel": 1,
      "editor.formatOnSave": true,
      "eslint.autoFixOnSave": true,
      "eslint.alwaysShowStatus": true,
  }​
  ```


   How to set it up globally: (I have not gotten it work yet)

    https://medium.com/@davidchristophersally/how-to-set-up-eslint-in-vscode-globally-253f25fbaff9

### Gif screen recoding program

https://www.screentogif.com/

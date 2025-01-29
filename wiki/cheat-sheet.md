# Programming Cheat Sheet

## Bash/ZSH

- Bash basics
```shell script
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
```shell script
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
```shell script
chmod 644 filename.sh   # change permission.
chmod +x filename.sh    # allows all permissions, creates executable .sh file
chmod 744 filename.sh   # allows .sh file to be executable
chown -R `whoami`:staff

stat -f "%A %a %N" filename.sh # find file permission in octal notation. eg: 644, 755
```

- Processes
```shell script
# MacOS terminal
lsof -i:portNumber # find process running on portNumber
lsof -i:portnumber -t # gets PID of process running on that port
kill -9 pid_number  # kills process running with pid_number
kill -9 `lsof -i:portNumber` # kills process on that specific portNumber

# Fow Windows cmd shell, run the following:
netstat -aon | findstr portNumber  # find the PID of a process running on portNumber
taskkill /PID typeyourPIDhere /F # kill that process
taskkill //PID typeyourPIDhere //F # for BASH on Windows
```

## Git

- Git basics
```shell script
git add
git status
git commit -m 'message here' # commits with message
git push
git remote -v # show origin/master. Can also click the config folder in .git folder

# If you already have a project created (separately then a git repo), here's how to connect them
git remote add origin https://github.com/lgc13/your-git-repo-here.git

```

- Branches
```shell script
git branch -a                # list all branches, local and remote
git branch -d branch name    # deletes branch locally.
  # use `-D` to force delete the branch
git branch -m new-name       # renames local branch name
git checkout -b branchName   # creates a branch and checks out to it
git push origin --delete branch_name # deletes remote branch
```

- Advanced

```shell script
git fetch —all —prune    # fetches origin, and prunes local comparing to it
git log                  # find previous commits and their commit_id s
git revert commit_id     # revert changes made by that commit_id
git reset --soft HEAD~1  # revert the last commit (locally)
git merge —abort         # aborts the merge (which has conflicts)
git checkout origin/master filename # reverts file back to how it is in master
git reset HEAD^          # gets rid of previous commit

git config --local user.email "my.email.here@gmail.com" # changes this specific repos email to push from (do it from proj root folder)
git config user.email # checks what user email you are using 

git commit -m "empty commit" --allow-empty
```

- Heroku client

```shell script
# If your app does not have a .git folder yet and you want to connect to a remote app, do the following:
git init
git remote -v # this will return nothing
heroku git:remote -a your-heroku-app-name-here # add your heroku app name
git remote -v # you will see them connected now
```

## Vim

- You can make permanent changes to your VIM editor by changing ~/.vimrc

- Vim basics:
```shell script
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
```shell script
w   # jumps to beginning of next word
b	  # move to beginning of previous word
0	  # move to start of line
$	  # move to end of line
Shift + V # highlights entire line
y	  # copies anything highlighted
Shift + p # pastes
```

- Making life easier
```shell script
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
\q   -- exits (END)/quits anything you’re in
\dn   -- shows all schemas
\du   -- show users
\dt   -- show all tables
\c database_name -- connects to a database_name
\conninfo -- shows connection info like db name, username name, and port
\i fullScriptPath.sql -- runs a scripts from your computer. Useful to add databases, creates users, etc

\! pg_dump existing_db_name > new_dumb_file.sql -- cloning: will create a dump backup file of your existing db. This file will be created in the desktop
-- alternatively, you can create a copy of the existing database into another one:
CREATE DATABASE backup_database WITH TEMPLATE existing_db_name;

    
-- DATABASES
CREATE DATABASE db_name; -- creates a db_name
DROP DATABASE db_name; -- deletes dbName

-- USERS/ROLES
CREATE ROLE roleName;
DROP user roleName; -- deletes that user/role

CREATE ROLE roleName
WITH LOGIN PASSWORD 'password'; -- creates a user `roleName` with login permission, and a password `password`
ALTER ROLE roleName WITH LOGIN;
ALTER ROLE roleName WITH PASSWORD 'newPassWordHere'; -- changes password for that user (roleName)

-- TABLES
CREATE TABLE table_name(col_1 type, col2 type(number)); -- creates a table
DROP TABLE table_name;

SELECT * FROM table_name; -- displays everything from a table
INSERT INTO table_name VALUES (info, info); -- insert a single row with all values from cols
UPDATE table_name SET col_name = new_value WHERE col_name = current_value; -- update row value
ALTER TABLE table_name ADD COLUMN new_col new_col_type; -- add col to table

UPDATE table_name SET col_name = ‘new_value’
WHERE other_col IN (‘row1_value’, ‘row2_value’); -- update multiple rows (from a single row query)
DELETE FROM table1 WHERE name = 'chris'
AND age = 24 AND sex = 'F' AND happy = 'M'; -- delete row depending on many col_values

-- Other
SET search_path TO someSchema; -- choose someSchema as search_path so now you can query any tables within it

-- Sequences
SELECT * FROM information_schema.sequences; -- shows all sequences in a database

create sequence IF not exists schemaName.sequenceName_id_seq
OWNED BY schemaName.tableName.colName; -- does as it says

SELECT currval('schemaName.sequenceName_id_seq'); -- displays sequence current value
SELECT nextval('schemaName.sequenceName_id_seq'); -- displays sequence next value
SELECT setval('schemaName.sequenceName_id_seq', 3, true); -- sets sequence value to 3, next value will be 4
```

```shell script
source ~/location_of/file_name.sql # import file into database
```

### AWS CLI

```shell script
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

  ```shell script
  aws s3 ls s3://dev-bucket-name/               # List default S3
  aws s3 ls s3://stg-bucket-name/ --profile stg # List stg S3
  aws s3 ls s3://prd-bucket-name/ --profile prd # List prd S3
  ```

### Python

#### [UV](https://docs.astral.sh/uv/getting-started/features/#next-steps)

```shell script
uv python dir: # Show the uv installed Python versions path.
```

#### Pipenv

Links to useful guides:
https://realpython.com/pipenv-guide/

```shell script
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

```shell script
docker ps # Checks instances running
docker container ls -a # Find all container instances (running and not running)
docker rm container_name # deletes container
docker rmi image_name # deletes image if there's no container

docker images # shows all images
docker compose up --build # build again

docker start instance_name # start instance
docker container start container_id # start a Docker container
docker stop container_id # Stop instance running

docker pull microsoft/mssql-server-linux # Installing SQL Server
docker run -d --name sql_server_demo -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=reallyStrongPwd123' -p 1433:1433 microsoft/mssql-server-linux # Install the Docker instance
```

### Microsoft SQLServer

```shell script
yarn global add sql-cli # Install the sql-cli command line shell
mssql -u sa -p reallyStrongPwd123 # Connect to sql-cli shell
```

### Brew

```shell script
brew doctor # open brew
update brew # updates brew
brew cask install java # install Java (or w/e else you might want)
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

```shell script
# List all installed by tech
sdk list techName # ex: sdk list java

sdk install techName versionNumber # ex: sdk install java 7.0.222-zulu
```

### iTerm2

```shell script
prompt -l       # lists the type of fonts available
prompt -p type  # try this one
prompt -s type  # activate this one
````

### IntelliJ Shortcuts

```shell script
CMD + O # find class
CMD + SHIFT + O # find file
CMD + SHIFT + F # find globally
CMD + SHIFT - OR + # collapses/expands everything collapsable
CMD + SHIFT + T # goes between test file and file being tested

CTRL + G # selects the next occurance of that word
OPTION + SHIFT # multiple cursor selection
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

- DB Migrations (mssql)
  
```shell script
  # To create a migration file:
  dotnet ef migrations add something
  
  # To update database:
  dotnet ef database update
```

### Setting up new Mac terminal environment

- Install iTerm2
  
   this should already have the `zsh` shell installed

- Run [create_links.sh](../.dotfiles/scripts/create_links.sh)
    
    - this should add: `oh-my-zsh`, `cobalt2`, `exa`
    - in case it doesn't, follow the following: 

        - Install [oh-my-zsh](https://ohmyz.sh/)
        
        - Get [Cobalt2](https://github.com/wesbos/Cobalt2-iterm)
        
        - Install [exa](https://the.exa.website/)
        
           - Add the following to `~/.bash_profile` once exa has been installed:
           `alias ls='exa --long --header --git -TL 1'`
        - Install zsh plugins:
          - [zsh-autosuggestion](https://github.com/zsh-users/zsh-autosuggestions/blob/master/INSTALL.md#oh-my-zsh)
            - `git clone https://github.com/zsh-users/zsh-autosuggestions ${ZSH_CUSTOM:-~/.oh-my-zsh/custom}/plugins/zsh-autosuggestions`
          - [zsh-syntax-highlighting](https://github.com/zsh-users/zsh-syntax-highlighting/blob/master/INSTALL.md)
            - `git clone https://github.com/zsh-users/zsh-syntax-highlighting.git ${ZSH_CUSTOM:-~/.oh-my-zsh/custom}/plugins/zsh-syntax-highlighting`
          - `source ~/.zshrc`
- Install an IDE/Text editor (Atom,VSCode)

### Eslint + Prettier

```shell script
- Updated for 2022

- Adding Eslint to VSCODE:

# 1. Add eslint to project
yarn add eslint -D

# 2. Set up initial eslint rules
yarn run eslint --init

- How would you like to use ESLint?: To check syntax, find problems, and enforce code style
- What type of modules does your project use?: JavaScript modules (import/export)
- Which framework does your project use?: React
- Does your project use TypeScript?: Yes
- Where does your code run? : Browswer
- How would you like to define a style for your project?: Use a popular style guide
- Which style guide do you want to follow?: Airbnb: https://github.com/airbnb/javascript
- What format do you want your config file to be in?: JSON
- Would you like to install them now with npm?: Yes

Note: You might wanna remove the package-lock.json file that was created

# 2.5 Add additional dependencies for Typescript:
yarn add eslint-config-airbnb-typescript --dev 

- for reference, these are all the dependencies I ended up having at this point:
  "devDependencies": {
    "@typescript-eslint/eslint-plugin": "^5.40.0",
    "@typescript-eslint/parser": "^5.40.0",
    "eslint": "^8.25.0",
    "eslint-config-airbnb": "^19.0.4",
    "eslint-config-airbnb-typescript": "^17.0.0",
    "eslint-plugin-import": "^2.26.0",
    "eslint-plugin-jsx-a11y": "^6.6.1",
    "eslint-plugin-react": "^7.31.10",
    "eslint-plugin-react-hooks": "^4.6.0"
  }

# 3. Fix .eslintrc

- Change eslintrc.json to a .eslintrc
- Add/change the following fields in it:
```

```json
{
	"env": {
		"browser": true,
		"es2021": true
	},
	"extends": ["plugin:react/recommended", "airbnb", "airbnb-typescript"],
	"parser": "@typescript-eslint/parser",
	"parserOptions": {
		"ecmaFeatures": {
			"jsx": true
		},
		"ecmaVersion": "latest",
		"sourceType": "module",
		"project": ["tsconfig.json"]
	},
	"plugins": ["react", "@typescript-eslint"],
	"rules": {
		"@typescript-eslint/indent": ["error", "tab"],
		"react/jsx-indent": ["error", "tab"],
		"no-tabs": 0,
		"object-curly-newline": "off"
	}
}
```

```shell script
# 4. Add VS code plugins
Eslint
Prettier - Code Formatter

# 5. Add workspace settings in VSCODE
- VScode > Code > Preferences > Settings
- Select `Workspace`
- Click the top right icon to see the `settings.json`
- Paste the following
```

```json
// Partial Youtube tutorial I followed: https://www.youtube.com/watch?v=eMgLHOrDkAs 
// github code: https://gist.github.com/ShaifArfan/1c41978b5b98d8cd95ab3a3f3ffac4fe

{
	"editor.defaultFormatter": "esbenp.prettier-vscode",
	"editor.formatOnSave": true,
	"[javascript]": {
		"editor.formatOnSave": false
	},
	"[javascriptreact]": {
		"editor.formatOnSave": false
	},
	"editor.codeActionsOnSave": {
		"source.fixAll": true
	},
	"eslint.alwaysShowStatus": true,
	"eslint.validate": [
		"javascript",
		"javascriptreact",
		"typescript",
		"typescriptreact"
	],
	"prettier.useTabs": true,
	"prettier.jsxSingleQuote": false,
	"prettier.tabWidth": 2,
	"prettier.arrowParens": "avoid",
	"prettier.singleQuote": true,
	"prettier.trailingComma": "all"
}


```

```shell script
# 6. DONE!

- errors should be highlighted red with squiglies now
- saving (CMD + S) should auto format now

```


```shell script
# 1. Add eslint to project
cd projDir
yarn add eslint -D # -D (same as --save-dev) saves as a devDepency

# 2. Install eslint dependencies
yarn add eslint-config-airbnb eslint-plugin-import eslint-plugin-jsx-a11y eslint-plugin-react babel-eslint -D


# 3. Install prettier and its dependencies
yarn add prettier eslint-config-prettier eslint-plugin-prettier -D

# 4. Add `.eslintrc` in your project root directory
touch .eslintrc  
```

5. In `.eslintrc`, add the following: [this file](../javascript/eslintrc-to-copy-from)

6. Allow your IDE's to use it:

- IntelliJ

   - activate ESLint: `Preferences > Editor > Inspections > Javascript > Code Quality Tools > Eslint (check)`
   
   - ~~add IntelliJ `jest` library (for JS only) `Preferences > Languanges & Frameworks > Javascript > Libraries > Download > then serach for jest`~~
   
   - add a `@types/jest` to your project with `yarn add @types/jest`
      - this will allow IntelliJ to give your `describe/it`s a nice color :)

   - add a keyboard bind:

   `Preferences > Keymap > Plug-ins > JavaScript and TypeScript > Fix ESLint Problems` (I suggest CMD + SHIFT + P)

- VC Code:

   1. Add the Eslint extension from the marketplace (for Visual Studio)
   
   2. Add these settings to your `settings.json`:
   
   ```json
   {
     "editor.formatOnSave": true,
     "eslint.autoFixOnSave": true,
     "eslint.alwaysShowStatus": true
   }​
   ```

### Java Prettier

[Documentation](https://github.com/jhipster/prettier-java)

```shell script
# in proj dir
yarn add prettier prettier-plugin-java -D

# Or globally
yarn add prettier prettier-plugin-java -D

# run prettier:
yarn prettier --write path/to/file.java # prettifies a specific file
yarn prettier --write "**/*.java" # prettifies all Java files in this dir
```

- Add any configuration/customization:

```shell script
# create a .prettierrc.yml file
touch .prettierrc.yml
```

You can make it look like [this one](../.dotfiles/prettierrc.yml)

- Add a KB shortut in IntelliJ

   1. Add an external tool: `Preferences > Tools > External Tools` 
      ```shell script
      Name: # w/e you want. ex: Prettier Java
      Program: ./node_modules/.bin/prettier
      Arguments: --write ../$FileRelativeDir$/$FileName$
      Working directory: # pathToProj/ || you can also use $ContentRoot$/../../
      ```
   2. Add shortcut: `Preferences > Keymap > External Tools > External Tools`
      - Pick your tool (ex: Prettier Java)
      - Add a shortcut (ex: CMD + SHIFT + J)
    3. Fix CMD + SHIFT + A shortcut: [instructions](https://intellij-support.jetbrains.com/hc/en-us/community/posts/360003367639-2019-1-Find-Action-shortcut-opens-terminal-securityuploadd-?page=1#community_comment_360000446239)

### VS Code settings

1. Install One Dark Pro Theme

2. Link your user settings.json to the one saved in this repo: [settings.json](../.dotfiles/vscode-settings.json)

   - You can use this [script](../.dotfiles/scripts/create_links.sh) to link it:

### Mac Tips

- Turn off Mojave Dock recent applications:

   Settings > Dock > 'Show recent applications in Dock'

- Gif screen recoding program

   https://www.screentogif.com/

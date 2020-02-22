# CI-CD | Continuous Integration, Continuous Delivery)

## GitHub

- add a `Worflow`

![github workflow](../img/github-workflow.png)

Ex: `Gradle`

- this will create a `repoName/.github/workflows/gradle.yml` file with the following:

```yaml
name: Java CI  # change this name to w/e you want 

on: [push]

jobs:
  build: # job name used in the next step

    runs-on: ubuntu-latest

    steps:
    - uses: actions/checkout@v2
    - name: Set up JDK 1.8   # change name
      uses: actions/setup-java@v1
      with:
        java-version: 1.8   # change to your Java version
    - name: Grant execute permission for gradlew
      run: chmod +x gradlew
    - name: Build with Gradle
      run: ./gradlew build

```

- require this workflow to pass in order to merge to master:

1. Add a rule in `myRepo > Settings > Branches > Branch protection rules > Add rule`
2. Branch name pattern: `master`
3. Check the `Require status checks to pass before merging` box
4. In `Status checks found in the last week for this repository`, add the `job` name that you want
   - in this case: `build` 
   
## Heroku


#!/usr/bin/env zsh

echo "Checking out the following repos to master:"

CURRENT_DIR=`pwd`

for repo in "${CURRENT_DIR}/"*; do
    if [[ -d "$repo/.git" ]] then
        cd $repo
        BRANCH=$(git rev-parse --abbrev-ref HEAD)
        if [[ $BRANCH != "master" ]] then
            echo "repo: $repo"
            git checkout master
            git pull
        fi
    fi
done
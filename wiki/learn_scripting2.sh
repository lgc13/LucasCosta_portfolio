#!/usr/bin/env bash
myTrueVar="I exist"
echo "myTrueVar: $myTrueVar"

if [[ $myTrueVar ]]; then
  echo "myTrueVar is not null... it is: $myTrueVar"
fi

myFalseVar=
echo "myFalseVar: $myFalseVar"

if [[ ! $myFalseVar ]]; then
  echo "myFalseVar doesnt exist"
fi

if [[ ! $myFalseVar && $myTrueVar ]]; then
  echo "myFalseVar doesnt exist, but myTrueVar does"
fi

cat test-data.yml | grep "_URL:" | awk '{$1=$1};1'

read-0() {
    while [ "$1" ]; do
        IFS=$'\0' read -r -d '' "$1" || return 1
        shift
    done
  } &&
  cat test-data.yml | shyaml key-values-0 secrets |
  while read-0 key value; do
      decodedString=$(echo $value | base64 --decode)
      echo "$key: $decodedString"
  done

SERVICE_NAME=
declare -A testsMap
testsMap=(
  ["some-key-1"]="MyTests1*"
  ["some-key-2"]="MyTests2*"
  ["some-key-3"]="MyTests3*"
  ["some-key-4"]="MyTests4*"
)
TEST_TO_RUN=`[ $SERVICE_NAME ] && echo ${testsMap[$SERVICE_NAME]} || echo "*"`
echo "TEST_TO_RUN: $TEST_TO_RUN"


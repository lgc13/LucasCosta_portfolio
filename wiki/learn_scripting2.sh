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
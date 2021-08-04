#fizz buzz activity

n=1
while [ $n -le 20 ]
do
if [ $((n%5)) -eq 0 ] &&  [ $(( n%3 )) -eq 0 ]
then
    echo "$n FizzBuzz"
    
elif [ $(( n%3 )) -eq 0 ]
then
   echo "$n Fizz"

elif [ $((n%5)) -eq 0 ]
then    
    echo "$n Buzz"

fi
   #n=$(( n+1 ))
   (( n++ ))
done
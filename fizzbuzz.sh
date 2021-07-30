#fizz buzz activity

n=1
while [ $n -le 20 ]
do
if [ $(( n%23 )) -eq 0 ]
then
   echo "Fizz"
elif [ $((n%5)) -eq 0 ]
then    
    echo "Buzz"
fi
   #n=$(( n+1 ))
   (( n++ ))
done
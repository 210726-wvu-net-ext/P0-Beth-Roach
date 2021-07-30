#Arithmatic shell script

read -p "Enter Number:" number

test=`expr $number % 2`
if [ $test -eq 0 ]
then
    echo "$number is even"
else
    echo "$number is odd"
fi





#read -p "Enter your Grade: " grade

# if [ "$grade" -le 40 ]
 #then   
  #    echo "Your Letter Grade is F"
 #elif [ "$grade" -ge 41 ]  && [ "$grade" -le 50 ]
 #then
  #   echo "Your Letter Grade is D"
 #elif [ "$grade" -ge 51 ]  && [ "$grade" -le 60 ]
 #then
  #   echo "Your Letter Grade is C"
 #elif [ "$grade" -ge 61 ]  && [ "$grade" -le 70 ]
 #then
  #   echo "Your Letter Grade is B"
# elif [ "$grade" -ge 71 ]  && [ "$grade" -lt 101 ]
# then
#     echo "Your Letter Grade is A"
 #fi
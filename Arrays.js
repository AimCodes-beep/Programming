const names=["Alice","Bob","Charlie"]
//ARRAY METHODDS
names.forEach(element => {
    console.log(element.toUpperCase())
});
//ARRAY OF OBJECTS
tasks=[
    {task_id:1001,task_name:"Coding",Category:"Study"},
    {task_id:1002,task_name:"Editing",Category:"Skills"},
    {task_id:1003,task_name:"Photography",Category:"Skills"},
 //   {"task_id":1004,"task_name":"Coding","Category":"Study"}

]
console.log(tasks[0]["task_name"])
//adding
tasks[3]={task_id:1004,task_name:"Arts and Craft",Category:"Hobbies"}
//looping over
for(let key in tasks){
  console.log(key,tasks[key])
}
//map method
let numbers=[1,2,3,4,5,6,7,8]
let squares=numbers.map(num=>num**2);
console.log(squares)
//filter method
let odd_num=numbers.filter(num=>num%2!=0)
console.log(`the odd numbers ${odd_num}`)//STRING INTERPOLATIONs
//sum of all elements
sum=0
for(let i=0;i<=numbers.length;i++){
    sum+=i
}
console.log(`the sum of all numbers is ${sum}`);
//REVERSING THE ARRAY
let start=numbers[0];
let end=numbers.length-1;
while(start<end){
    let temp=numbers[start];
    numbers[start]=numbers[end];
    numbers[end]=temp;
    start++;
    end--
}
numbers.forEach(elem=>{
    console.log(elem)
})
//linear search
let is_found=false;
let search=11; //NUMBERS TO SEARCH FOR
for(let i=1;i<numbers.length;i++){
    if(search==numbers[i]){
        console.log("Number founded")
        is_found=true;
        break;
    }
    else{
        is_found=false;
    }
}
console.log(is_found)
//OBJECTS
console.log("OBJECTS IN JAVASCRIPT")
person={
    name:"Aiman Nisar",
    age:20,
    degree:"BSCS",
    specialization:"Data Science"
}
//accessing objects values
console.log(person.age)
//ADDING NEW VALUE
person["city"]="karachi";
for(let key in person){
    console.log(`${key}:${person[key]}`);
}
//NESTED OBJECTS
students={
   2312393: {id:2312393,name:"Areeba Zulfiqar",course:"Quality Assurance"},
   2312129: {id:2312129,name:"Aiman Nisar",course:"Data Analysis"},
   2312394:{id:2312394,name:"Laiba Jabbar",course:"Data Analysis"}
}
//accessing 2nd subject
console.log(students["2312129"]["course"])
for(let k in students){
    console.log(`key :${k}:${students[k]}`)

}
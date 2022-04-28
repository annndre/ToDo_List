
function Selection() {
    var selected = document.getElementById("select1");
    if (selected.value == 1) {
        document.getElementById("input1").removeAttribute("hidden");
        
    }
   // document.getElementById("input1").setAttribute("hidden");
   
}

function Input() {
    var selected = document.getElementById("select1");
    var option = document.getElementById("option1");

    selected.value = document.getElementById("input1").value;
    option.value = document.getElementById("input1").value;
   
   // console.log(option.value)
    //console.log(selected.value)
}
function HideInput() {
    
    var hide = document.getElementById("AddTodo");
    var selected = document.getElementById("select1");
    var input = document.getElementById("input1");
    var option = document.getElementById("option1");
    hide.addEventListener('mouseout',function () {
        input.setAttribute("hidden", true);
        input.value = null;
       // alert("hide");
    });
    option.value = 1;
    
}

function move() {
    var moving = document.getElementById("ToDoProgress");
    
}

//function HideCheckbox() {
//    var ToDoItem = document.getElementById("ToDoItem");
//    var checkbox = document.querySelector(checkbox);

//    if (ToDoItem.style.background == 'orange') {
//        checkbox.setAttribute("disabled", true);
//    }
//}

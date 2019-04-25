let todos = [
  {id: 1, text: "Take out trash and recycling", complete: true},
  {id: 2, text: "Pick up dry cleaning", complete: false},
  {id: 3, text: "Get oil change", complete: false},
  {id: 4, text: "Write thank-you notes", complete: false},
];

function displayTodosText() {
    for (var i = 0; i < todos.length; i++) {
        document.write('<div class="todo">')
        document.write('<input type="checkbox" onclick="updateCompletedTask()"  class="todo-checkbox" name="todo-complete"id="checkbox"/>')
        document.write('<span for="todo-complete" class="todo-text" id="todo-text">' + todos[i].text + '</span>')
        document.write('</div>')
    }
}

function updateCompletedTask(){
   var x = document.getElementById("checkbox").checked;
   if (x == true){
    this.complete = x;
    console.log(this.complete);
   }
   else {
     this.complete = false;
     console.log(this.complete);
   }


  }

//initial commit

let todos = [
  {id: 1, text: "Take out trash and recycling", complete: true},
  {id: 2, text: "Pick up dry cleaning", complete: false},
  {id: 3, text: "Get oil change", complete: false},
  {id: 4, text: "Write thank-you notes", complete: false},
];

const displayInitialTodo = () => {
  const mainTodoList = document.getElementById('main-todo-list');
  const todoDiv = document.getElementsByClassName('todo')[0]; // make a copy of main todo div

  document.getElementsByClassName('todo')[0].remove(); // delete current

  todos.forEach((todo) => {
    newTodoDiv = todoDiv.cloneNode(true);
    newTodoDiv.getElementsByTagName('span')[0].innerHTML = todo.text;
    newTodoDiv.getElementsByTagName('span')[0].id = todo.id;
    styleTodoItem(todo, newTodoDiv);
    mainTodoList.appendChild(newTodoDiv);
  });
}

const styleTodoItem = (todoItem, divTodo) => {

  if (todoItem.complete) {
    divTodo.className = 'todo complete';
  } else {
    divTodo.className = 'todo';
  }
}


const checkBoxPress = (input) => {
  const todoId = Number(input.parentElement.getElementsByClassName('todo-text')[0].id); // get todoId of item clicked on

  const todoItem = todos.find(todo => todo.id === todoId); // find item with that id

  todoItem.complete ? todoItem.complete = false : todoItem.complete = true;

  styleTodoItem(todoItem, input.parentElement);

  todos.filter((todo) => todo.complete == true )
    .forEach((todo) => {console.log('true:' , todo.text)});
  console.log('------');
}


displayInitialTodo();

todos.filter((todo) => todo.complete == true )
  .forEach((todo) => {console.log('true:' , todo.text)});
console.log('------');

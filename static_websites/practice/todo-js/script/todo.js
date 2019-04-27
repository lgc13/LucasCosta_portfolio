let todos = [
  {id: 1, text: "Take out trash and recycling", complete: true},
  {id: 2, text: "Pick up dry cleaning", complete: false},
  {id: 3, text: "Get oil change", complete: false},
  {id: 4, text: "Write thank-you notes", complete: false},
];
let itemsComplete = todos.filter((todo) => todo.complete === true).length;

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
    if (todo.complete === true) {
      itemsComplete =+ 1;
    }
    changeItemsRemain();
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
  // get todoId of item clicked on
  const todoId = Number(input.parentElement
    .getElementsByClassName('todo-text')[0].id);

  // find item with that id
  const todoItem = todos.find(todo => todo.id === todoId);

  if (todoItem.complete) {
    todoItem.complete = false;
    itemsComplete -= 1;
  } else {
    todoItem.complete = true;
    itemsComplete += 1;
  }

  styleTodoItem(todoItem, input.parentElement);

  changeItemsRemain();

  todos.filter((todo) => todo.complete == true )
    .forEach((todo) => {console.log('true:' , todo.text)});
  console.log('------');
}

const changeItemsRemain = () => {
  document.getElementById('remaining-count')
    .innerHTML = todos.length - itemsComplete;
}

displayInitialTodo();

let todos = [
  {id: 1, text: "Take out trash and recycling", complete: true},
  {id: 2, text: "Pick up dry cleaning", complete: false},
  {id: 3, text: "Get oil change", complete: false},
  {id: 4, text: "Write thank-you notes", complete: false},
];

const displayTodo = () => {
  const mainTodoList = document.getElementById('main-todo-list');
  const todoDiv = document.getElementsByClassName('todo')[0];

  document.getElementsByClassName('todo')[0].remove();

  todos.forEach((todo) => {
    newTodo = todoDiv.cloneNode(true);
    newTodo.getElementsByClassName('todo-text')[0].innerHTML = todo.text;
    mainTodoList.appendChild(newTodo);
  });
}

displayTodo();

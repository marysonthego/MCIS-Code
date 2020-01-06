function createParagraph() {
    let para = document.createElement('p');
    para.textContent = 'You clicked the button!';
    document.body.appendChild(para);
  }
  
  const buttons = document.querySelectorAll('button');
  
  for(let i = 0; i < buttons.length ; i++) {
    buttons[i].addEventListener('click', createParagraph);
  }

  function walkTree(node) {
    if (node == null) // 
      return;
    // do something with node
    for (var i = 0; i < node.childNodes.length; i++) {
      walkTree(node.childNodes[i]);
    }
  }

  function multiply(a, b) {
    b = typeof b !== 'undefined' ?  b : 1; //set a default for b (pre 2015)
  
    return a * b;
  }
  
  //multiply(5); // 5

  function multiply(a, b = 1) {
    return a * b;
  }
  
  //multiply(5); // 5

  //Rest parameters
  function multiply(multiplier, ...theArgs) {
    return theArgs.map(x => multiplier * x);
  }
  
  //var arr = multiply(2, 1, 2, 3);
  //console.log(arr); // [2, 4, 6]

  function JSClock() {
    var time = new Date();
    var hour = time.getHours();
    var minute = time.getMinutes();
    var second = time.getSeconds();
    var temp = '' + ((hour > 12) ? hour - 12 : hour);
    if (hour == 0)
      temp = '12';
    temp += ((minute < 10) ? ':0' : ':') + minute;
    temp += ((second < 10) ? ':0' : ':') + second;
    temp += (hour >= 12) ? ' P.M.' : ' A.M.';
    return temp;
  }
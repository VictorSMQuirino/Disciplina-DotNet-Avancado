using Exercicio_3;

var worker1 = new Worker(1);
var worker2 = new Worker(2);

var t1 = new Thread(worker1.Work);
var t2 = new Thread(worker2.Work);

t1.Start();
t2.Start();
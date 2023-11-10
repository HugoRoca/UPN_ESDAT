Queue<string> queue = new Queue<string>();

// This create a queue
queue.Enqueue("Shelly");
queue.Enqueue("Samuel");
queue.Enqueue("Ratamanche");
queue.Enqueue("Jehidi");

//Dequeue and show items
while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}
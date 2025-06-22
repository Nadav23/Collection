using Collection;


CollectionOperations co = new CollectionOperations();

Stack<DateTime> stack = new Stack<DateTime>();
stack.Push(DateTime.MaxValue);

co.StackOperations(stack);
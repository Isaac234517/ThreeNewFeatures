// See https://aka.ms/new-console-template for more information

static void Display(string msg) => Console.WriteLine(msg);



//lambda improvement 
Func<int, int ,int> add = (int a, int b) => a + b;

var add = (int a, int b ) => a + b;



People p = new People("Bunny", 9988);


List<People> containers = new List<People>(){
    p
};

string j = JsonConvert.SerializeObject(p);

Display(j);





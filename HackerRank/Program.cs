// See https://aka.ms/new-console-template for more information
 
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;

Console.WriteLine("Hello, World!");

//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
//string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//int n = Convert.ToInt32(firstMultipleInput[0]);

//int d = Convert.ToInt32(firstMultipleInput[1]);



//int t = Convert.ToInt32(Console.ReadLine().Trim());
 

temp.IEnumeratorLoop(); 


int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
int res = minimumSwaps(arr);


Console.WriteLine(res);




//List<int> result = rotLeft(a, d);

//Console.WriteLine(minimumBribes(a, n));

//Console.WriteLine(result);

//int total = getTotalX(arr, brr);

//Console.WriteLine(String.Join(" ", result));
string asdasd = Console.ReadLine();

//textWriter.Flush();
//textWriter.Close();

static int jumpingOnClouds(List<int> c)
{
    int steps = 0;
    for (int index = 1; index < c.Count(); index++)
    {
        if (c[index] == 1 || (index + 1 < c.Count() && c[index] == 0 && c[index + 1] == 0))
        {
            index++;
        }
        if (index != (c.Count() - 1))
        {
            steps++;
        }

    }
    return steps;
}

static long repeatedString(string s, long n)
{
    long stringLength = s.Length;
    string newString = "";
    long times = n / stringLength;
    // char[] charArray = s.ToCharArray();

    for (long i = 0; i < times; i++)
    {

        newString += s;

    }
    newString = newString.Remove((int)(n - 1), (int)(stringLength % n));
    long result = newString.ToCharArray().Count(c => c == 'a');
    return result;
}

static int findFruitInArea(int s, int t, int tree, List<int> fruits)
{
    int fruitCounter = 0;
    int totalFruitInArea = 0;
    foreach (int fruit in fruits)
    {
        fruitCounter = tree + fruit;
        if (fruitCounter >= s || fruitCounter <= t)
        {
            totalFruitInArea++;
        }
    }
    return totalFruitInArea;
}



static string kangaroo(int x1, int v1, int x2, int v2)
{
    string match = "NO";
    int kangroo2 = x2;
    for (int i = x1; i < 100000000; i += v1)
    {
        if (i != x1)
            kangroo2 += v2;
        if (kangroo2 == i)
        {
            match = "YES";
            return match;
        }
    }
    return match;
}


static string kangaroo2(int x1, int v1, int x2, int v2)
{
    string match = "NO";
    List<int> kangroo1JumpLocations = new List<int>();
    List<int> kangroo2JumpLocations = new List<int>();
    for (int i = x1; i < 100000000; i += v1)
    {
        kangroo1JumpLocations.Add(i);
    }

    for (int k = x2; k < 100000000; k += v2)
    {
        kangroo2JumpLocations.Add(k);
    }

    int result = 0;
    result = kangroo1JumpLocations.Where(m => kangroo2JumpLocations.Contains(m)).FirstOrDefault();
    if (result != 0)
        match = "YES";
    return match;
}

static int getTotalX(List<int> a, List<int> b)
{
    int result = 0;

    // Get LCM of all elements of a
    int lcm = a[0];
    foreach (var item in a)
        lcm = getLCM(lcm, item);

    int gcd = b[0];

    foreach (var item in b)
        gcd = getGCD(gcd, item);

    int multiple = 0;
    while (multiple <= gcd)
    {
        multiple += lcm;

        if (gcd % multiple == 0)
            result++;
    }
    return result;


}

static int getGCD(int n1, int n2)
{
    if (n2 == 0)
    {
        return n1;
    }
    return getGCD(n2, n1 % n2);
}

static int getLCM(int n1, int n2)
{
    if (n1 == 0 || n2 == 0)
        return 0;
    else
    {
        int gcd = getGCD(n1, n2);
        return Math.Abs(n1 * n2) / gcd;
    }
}

static List<int> breakingRecords(List<int> scores)
{
    List<int> resList = new List<int>();
    int minScore = scores[0], maxScore = scores[0];
    int minScoreCounter = 0, maxScoreCounter = 0;
    foreach (var item in scores)
    {
        if (item < minScore)
        {
            minScore = item;
            minScoreCounter++;

        }

        if (item > maxScore)
        {
            maxScore = item;
            maxScoreCounter++;
        }
    }
    resList.Add(maxScoreCounter);
    resList.Add(minScoreCounter);
    return resList;
}

static int birthday(List<int> s, int d, int m)
{
    int counter = 0;
    int tempCounter = 0, result = 0;
    int tempTotal = 0;
    for (int k = 0; k < s.Count; k++)
    {
        for (int i = 0; i < m; i++)
        {
            if ((tempCounter != s.Count - 1) || tempCounter == 0)
            {
                tempCounter = k + i;
                tempTotal += s[tempCounter];
                if ((tempTotal == d) && (i == m - 1))
                {
                    counter++;
                }

            }
        }
        tempTotal = 0;
    }
    return counter;
}

//static int numberOfPaths(int[][] a, int M, int N)
//{
//    int counter = 0;
//    for (int i = 0; i < M; i++)
//    {

//        for (int j = 0; j < N; j++)
//        {
//            if ((j > (i + 1)) || (i > (j + 1)))
//                break;
//            if (a[i][j] == 1)
//            {
//                counter++;
//            }
//        }
//    }

//}



static int numberOfPaths(int[][] arr, int m, int n, int count)
{
    if (m == arr.GetLength(0) || n == arr[0].Length)
    {
        return count;
    }
    if (arr.GetLength(0) - 1 == m && arr[0].Length - 1 == n)
    {
        count++;
        return count;
    }
    if (n < arr[0].Length - 1 && arr[m][n + 1] != 0)
    {
        count = numberOfPaths(arr, m, n + 1, count);
    }
    if (m < arr.GetLength(0) - 1 && arr[m + 1][n] != 0)
    {
        count = numberOfPaths(arr, m + 1, n, count);
    }
    return count;
}

static List<int> listLoop(List<int> arr, int n)
{
    //List<int> list = new List<int>(arr);
    int t = arr[0];
    //list[0] = arr[arr.Count - 1];
    //list[arr.Count - 1] = arr[0];

    for (int i = 0; i < n - 1; i++)
    {
        arr[i] = arr[i + 1];
    }
    arr[n - 1] = t;

    return arr;
}

static List<int> rotLeft(List<int> a, int d)
{

    for (int i = 0; i < d; i++)
    {
        a = new List<int>(listLoop(a, a.Count));
    }
    return a;
}

static List<Numbers> findDiff(List<int> arr, int i, List<Numbers> numbers, bool inner)
{

    Numbers newNumb = new Numbers();
    int tempNumber;
    if (!numbers.Any())
        numbers = new List<Numbers>();
    int index = arr.FindIndex(a => a.Equals(i + 1));
    int diff = Math.Abs(i - index);
    if (diff > 2)
    {

        if (i != arr.Count - 1 || inner)
        {

            numbers = findDiff(arr, index, numbers, true);
            if (arr[i] != (i + 1))
                numbers = findDiff(arr, i, numbers, true);
            else
                inner = false;

        }
        else
            return new List<Numbers>();
    }
    else
    {
        tempNumber = arr[index];
        arr[index] = arr[i];
        arr[i] = tempNumber;

        if (arr[i] > arr[index])
        {
            if (numbers.Where(k => k.Value == arr[i]).Select(x => x).FirstOrDefault() != null)
                numbers.Where(k => k.Value == arr[i]).Select(x => x).FirstOrDefault().timesMove += diff;
            else
            {
                newNumb.Value = arr[i];
                newNumb.timesMove = diff;
                numbers.Add(newNumb);
            }
        }
        else
        {
            if (numbers.Where(k => k.Value == arr[index]).Select(x => x).FirstOrDefault() != null)
                numbers.Where(k => k.Value == arr[index]).Select(x => x).FirstOrDefault().timesMove += diff;
            else
            {
                newNumb.Value = arr[index];
                newNumb.timesMove = diff;
                numbers.Add(newNumb);
            }
        }

    }
    return numbers;

}

static int changeFromLeft(List<int> a, int k)
{

    int index, diff, counter = 0, tempNumber;

    List<int> sortedList = new List<int>(a);
    sortedList.Sort();

    for (int i = k; i < sortedList.Count; i++)
    {
        diff = 0;

        index = a.FindIndex(k => k.Equals(i + 1));
        diff = Math.Abs(i - index);
        if (diff > 2)
            return -1;
        if (diff != 0)
        {
            for (int l = 1; l <= diff; l++)
            {

                tempNumber = a[l + i];
                a[l + i] = a[i];
                a[i] = tempNumber;
                counter++;
            }
        }


    }
    return counter;
}

static int changeFromRight(List<int> a, int k, int counter)
{
    int index, diff, tempNumber;

    for (int i = a.Count - 1; i >= k; i--)
    {
        diff = 0;



        index = a.FindIndex(k => k.Equals(i + 1));
        diff = Math.Abs(i - index);

        if (diff > 2)
            if ((i + 1) < a[i])
                return -1;
            else
                counter = changeFromRight(a, i, counter);
        else
        {

            tempNumber = a[index];
            a[index] = a[i];
            a[i] = tempNumber;
            counter += diff;
        }

    }
    return counter;
}

static string minimumBribes(List<int> a, int n, int k)
{
    int counter = 0, tempNumber, tempCounter = 1;
    string res = "Too chaotic";

    List<int> sortedList = new List<int>(a);
    sortedList.Sort();

    for (int i = k; i < sortedList.Count; i++)
    {
        tempCounter = 0;
        while (sortedList[i] != a[i])
        {
            tempCounter++;

            tempNumber = sortedList[i + tempCounter];
            sortedList[i + tempCounter] = sortedList[i];
            sortedList[i] = tempNumber;
            counter++;
            if (tempCounter > 2)
                return res;
        }
    }
    res = counter.ToString();
    return res;
}

static int minimumSwaps(int[] arr)
{
    int index,indexFromLast, tempNumber = 0, counter = 0,counterFromLast;
    int[] sortedArr = new int[arr.Length];
    Array.Copy(arr, sortedArr,arr.Length);
    Array.Sort(sortedArr);

    int halfofArrLength = arr.Length % 2 == 0 ? arr.Length / 2 : (arr.Length + 1) / 2;
    counterFromLast = arr.Length - 1;

    for (int i = 0; i < halfofArrLength; i++)
    {

        if (arr[i]  != (i +1 ) )
        {
            index = Array.FindIndex(arr, w => w.Equals(sortedArr[i]));
            tempNumber = arr[i];
            arr[i] = i+1;
            arr[index] = tempNumber;
            counter++;
        }
         
        if (arr[counterFromLast - i] != (arr.Length - i))
        {
            indexFromLast = Array.FindIndex(arr, w => w.Equals(sortedArr[counterFromLast - i]));
            tempNumber = arr[counterFromLast - i];
            arr[counterFromLast - i] = (arr.Length - i);
            arr[indexFromLast] = tempNumber;
            counter++;
        }

    }
    return counter;
    

}

class Program2
{
    static Dictionary<int, string> askerler;
    static void Main(string[] args)
    {
        askerler = new Dictionary<int, string>();
        AtamaGerceklestir().Wait();
        foreach (KeyValuePair<int, string> item in askerler)
            Console.WriteLine($"{item.Key} - {item.Value}");
        Console.Read();
    }

    static async Task Ata(string bolukAdi)
    {
        for (int i = 1; i <= 100; i++)
        {
            await Task.Delay(100);
            if (!askerler.ContainsKey(i))
                askerler.TryAdd(i, bolukAdi);
        }
    }

    static async Task AtamaGerceklestir()
    {
        var task1 = Ata("1. Bölük");
        var task2 = Ata("2. Bölük"); 

        await Task.WhenAll(task1, task2);
    }
}

class Personel
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public string SoyAdi { get; set; }
}

class PersonelEnumerator : IEnumerator<Personel>
{
    List<Personel> Kaynak;
    int currentIndex = -1;
    public PersonelEnumerator(List<Personel> Kaynak) => this.Kaynak = Kaynak;
    public Personel Current => Kaynak[currentIndex];
    object IEnumerator.Current => Kaynak[currentIndex];
    public void Dispose() => Console.WriteLine("İterasyon bittiii...");
    public bool MoveNext() => ++currentIndex < Kaynak.Count;
    public void Reset() => currentIndex = 0;
}


class Program3
{
    static ConcurrentDictionary<int, string> askerler;
    static void Main(string[] args)
    {
        askerler = new ConcurrentDictionary<int, string>();
        AtamaGerceklestir().Wait();
        foreach (KeyValuePair<int, string> item in askerler)
            Console.WriteLine($"{item.Key} - {item.Value}");
        Console.Read();
    }

    static async Task Ata(string bolukAdi)
    {
        for (int i = 1; i <= 100; i++)
        {
            await Task.Delay(100);
            if (!askerler.ContainsKey(i))
                askerler.TryAdd(i, bolukAdi);
        }
    }

    static async Task AtamaGerceklestir()
    {
        var task1 = Ata("1. Bölük");
        var task2 = Ata("2. Bölük");

        await Task.WhenAll(task1, task2);

    }
     

   
}

class Personeller : IEnumerable<Personel>
{
    List<Personel> PersonelListesi = new List<Personel>();
    public void Add(Personel p) => PersonelListesi.Add(p);
    public IEnumerator<Personel> GetEnumerator() => new PersonelEnumerator(PersonelListesi);
    IEnumerator IEnumerable.GetEnumerator() => new PersonelEnumerator(PersonelListesi);
}

class temp
{
    public static void IEnumeratorLoop()
    {
        Personeller personeller = new Personeller();
        personeller.Add(new Personel { Id = 1, Adi = "Gençay", SoyAdi = "Yıldız" });
        personeller.Add(new Personel { Id = 2, Adi = "Aslı", SoyAdi = "Cambaz" });
        personeller.Add(new Personel { Id = 3, Adi = "Elif", SoyAdi = "Gök" });
        personeller.Add(new Personel { Id = 4, Adi = "Aykız", SoyAdi = "Yıldız" });
        personeller.Add(new Personel { Id = 5, Adi = "Erol", SoyAdi = "Burçak" });
        foreach (Personel personel in personeller)
            Console.WriteLine($"ID : {personel.Id}\nAdı : {personel.Adi}\nSoyadı : {personel.SoyAdi}\n*****");
        Console.Read();
    }
}
class Numbers
{
    public int Value { get; set; }
    public int timesMove { get; set; }
}



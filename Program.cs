string[] strArray = new string [4]{ "Hello", "2", "world", ":-)" };
string[] newArray = new string [strArray.Length];

void CreateNewArray(string[] strArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= 3)
        {
            newArray[count] = strArray[i];
            count++;
        }
    }
}
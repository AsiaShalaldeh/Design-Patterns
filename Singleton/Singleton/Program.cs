namespace SingletonPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Parallel.Invoke(
              () =>
              {
                  Singleton fromTeacher = Singleton.GetInstance;
                  fromTeacher.PrintDetails("From Teacher");
              },
              () =>
              {
                  Singleton fromStudent = Singleton.GetInstance;
                  fromStudent.PrintDetails("From Student");
              }
              );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_IEnumerableProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //SolveArray_IEnumerableProblem01();
            SolveArrayStoredType();
        }

        static void SolveArray_IEnumerableProblem01()
        {
            string[] employees = { "Joe", "Bob", "Carol", "Alice", "Will" };

            //제네릭이 아닌 유형 또는 메소드 '식별자'는 유형 인수와 함께 사용할 수 없습니다.
            IEnumerable<string> employeeQuery =
                from person in employees
                orderby person
                select person;

            foreach(string employee in employeeQuery)
            {
                Console.WriteLine(employee);
            }
        }

        static void SolveArrayStoredType()
        {
            //10, 4, 44, 69, 39, 56, 64, 31, 28, 14, 22, 50
            
        }
    }
}

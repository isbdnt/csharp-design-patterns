using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class PeopleEnumerator : IEnumerator<Person>
    {
        public Person[] people;

        int position = -1;

        public PeopleEnumerator(Person[] list)
        {
            people = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < people.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

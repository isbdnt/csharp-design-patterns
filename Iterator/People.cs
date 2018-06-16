using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class People : IEnumerable<Person>
    {
        private Person[] _people;
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return new PeopleEnumerator(_people);
        }
    }
}

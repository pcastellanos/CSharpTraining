using System;

namespace CSharpTraining
{
    internal class MyIterator : IIterator
    {
        private MyAggregate aggregate;
        private int currentIndex=0;

        public MyIterator(MyAggregate myAggregate)
        {
            aggregate = myAggregate;
        }

        public string CurrentItem
        {
            get
            {
                return aggregate[currentIndex];
            }
        }

        public string FirstItem
        {
            get
            {
                currentIndex = 0;
                return aggregate[currentIndex];
            }
        }

        public bool IsDone
        {
            get
            {
                return !(currentIndex < aggregate.Count);
            }
        }

        public string NextItem
        {
            get
            {
                currentIndex += 1;
                return !IsDone ? aggregate[currentIndex] : string.Empty;
            }
        }
    }
}
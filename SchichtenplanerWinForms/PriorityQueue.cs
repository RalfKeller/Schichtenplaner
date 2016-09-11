using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchichtenplanerWinForms
{
    public class PriorityQueue<E>
    {
        private List<QueueElement> lstElements;

        public PriorityQueue()
        {
            lstElements = new List<QueueElement>();
        }

        public void add(E item, int prio)
        {
            QueueElement newElement = new QueueElement(item, prio);

            bool inserted = false;
            for (int i = 0; i < lstElements.Count; i++)
            {
                QueueElement currentElement = lstElements[i];
                if(currentElement.iPrio <= newElement.iPrio)
                {
                    inserted = true;
                    lstElements.Insert(i, newElement);
                    break;
                }
            }

            if (!inserted)
                lstElements.Add(newElement);
        }

        public E pop()
        {
            if (lstElements.Count == 0)
                throw new ArgumentOutOfRangeException();

            QueueElement topPrio = lstElements[0];
            lstElements.Remove(topPrio);

            return topPrio.data;
        }

        public int Count()
        {
            return lstElements.Count;
        }

        class QueueElement
        {
            public E data { get; private set; }
            public int iPrio { get; private set; }

            public QueueElement(E data, int iPrio)
            {
                this.data = data;
                this.iPrio = iPrio;
            }
        }
    }
}

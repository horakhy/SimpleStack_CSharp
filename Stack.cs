using System;

namespace ProgramStructure
{
    public class Stack{
        
        Position first;

        public void Push(object item){
            first = new Position(first, item);
        }

        public object Pop(){
            if(first == null)   throw new InvalidOperationException();

            object result = first.item;
            first = first.next;
            return result;
        }
    }

    class Position{

        public Position next;

        public object item;

        public Position(Position next, object item){
            this.next = next;
            this.item = item;
        } 
    }
}

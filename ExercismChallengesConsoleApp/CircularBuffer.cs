namespace ExercismChallengesConsoleApp
{
    public class CircularBuffer<T>
    {

        public int readIndex;
        public int writeIndex;
        public T[] buffer;
        public CircularBuffer(int capacity)
        {
            buffer = new T[capacity];
            readIndex = 0;
            writeIndex = 0;
        }

        public T Read()
        {
            if(writeIndex == 0)            
                throw new InvalidOperationException();
            
            T result = buffer[readIndex];

            if (readIndex == buffer.Length - 1)
            {
                readIndex = 0;  
            }
            else
            {
                readIndex++;
            }
            
            return result;
        }

        public void Write(T value)
        {
            if(writeIndex == buffer.Length)
                throw new InvalidOperationException();

                buffer[writeIndex++] = value;
        }

        public void Overwrite(T value)
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public void Clear()
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}

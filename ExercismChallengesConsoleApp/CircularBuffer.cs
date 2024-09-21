namespace ExercismChallengesConsoleApp
{
    public class CircularBuffer<T>
    {

        public int readIndex;
        public int writeIndex;
        public T[] buffer;
        public CircularBuffer(int capacity)
        {
            buffer = new T[];
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

            if(writeIndex < buffer.Count -1)
            {
                writeIndex++;
                buffer[writeIndex] = value;
            }
            else
            {
                writeIndex = 0;
            }
        }

        public void Overwrite(T value)
        {
            buffer[readIndex] = value;
            readIndex++;
        }

        public void Clear()
        {
            buffer = new List<T>();
        }
    }
}

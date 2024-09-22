using System.Globalization;

namespace ExercismChallengesConsoleApp
{
    public class CircularBuffer<T>
    {
        T[] buffer;

        int readIndex = 0;
        int writeIndex = 0;
        public CircularBuffer(int capacity) => buffer = new T[capacity];
        

        public T Read()
        {
            if(IsEmpty)
                throw new InvalidOperationException("Cannot read from empty buffer");
            return buffer[Wrap(readIndex++)];
        }

        public void Write(T value)
        {
            if (IsFull)
                throw new InvalidOperationException("Cannot write to full buffer");

            buffer[Wrap(writeIndex++)] = value;
        }

        public void Overwrite(T value)
        {
            if (IsFull)
                readIndex++;
            Write(value);
        }

        public void Clear()
        {
            writeIndex = readIndex;
        }

        private int Length => writeIndex - readIndex;

        public bool IsEmpty => readIndex == writeIndex;

        public bool IsFull => buffer.Length == Length;

        private int Wrap(int n) => n % buffer.Length;

    }
}

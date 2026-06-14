public class DynamicArray {
    private int capacity = 0;
    private int size = 0;
    private int[] source;

    public DynamicArray(int capacity) {
        this.capacity =  capacity;
        this.source = new int[this.capacity];
        this.size = 0;
    }

    public int Get(int i) {
        return this.source[i];
    }

    public void Set(int i, int n) {
        this.source[i] = n;
        if(i > size - 1) size++;
    }

    public void PushBack(int n) {
        if(size == capacity) this.Resize();
        this.source[size] = n;
        this.size++;
    }

    public int PopBack() {
        int num = this.source[this.size-1];
        size--;
        return num;
    }

    private void Resize() {
        int[] resized_source = new int[this.capacity *= 2];
        for(int i = 0; i < size; i++) {
            resized_source[i] = this.source[i];
        }

        this.source = resized_source;
    }

    public int GetSize() {
        return this.size;
    }

    public int GetCapacity() {
        return this.capacity;
    }
}

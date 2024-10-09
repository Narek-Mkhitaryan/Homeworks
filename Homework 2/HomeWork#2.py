                                      #Implement Insertion Sort recursively.

def recursive_insertion_sort(array, size):
    if size <= 1:
        return

    recursive_insertion_sort(array, size-1)
    last_element = array[size-1]
    index = size-2

    while index >= 0 and array[index] > last_element:
        array[index+1] = array[index]
        index -= 1

    array[index+1] = last_element

array = [12, 11, 13, 5, 6]
recursive_insertion_sort(array, len(array))
print("Sorted array is:", array)

#-----------------------------------------------------------------------------------------------------------------------
                                        #Implement a Custom Queue using a list.

class MyQueue:
    def __init__(self):
        self.items = []

    def is_empty(self):
        return len(self.items) == 0

    def add(self, element):
        self.items.append(element)

    def remove(self):
        if self.is_empty():
            raise IndexError("Remove from an empty queue")
        return self.items.pop(0)

    def front(self):
        if self.is_empty():
            raise IndexError("Front from an empty queue")
        return self.items[0]

    def length(self):
        return len(self.items)

queue_instance = MyQueue()
queue_instance.add(1)
queue_instance.add(2)
queue_instance.add(3)
print("Removed item is:", queue_instance.remove())
print("Front item is:", queue_instance.front())
print("Queue length is:", queue_instance.length())

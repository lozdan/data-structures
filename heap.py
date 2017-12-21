# author        : Daniel Lozano
# documentation : https://en.wikipedia.org/wiki/Heap_(data_structure)

class Heap:
    def __init__(self):
        self.elements = []

    def _swap(self, x, y):
        """Swap two values from `elements` given its indices"""
        self.elements[x], self.elements[y] = self.elements[y], self.elements[x]
    
    def peek(self):
        """Return the minimum value from the heap"""
        if not self.elements:
            raise Exception("Cannot peek from an empty heap")
        return self.elements[0]
    
    def push(self, value):
        """Add a new element to the heap"""
        self.elements.append(value)
        current = len(self.elements) - 1
        while current != 0:
            parent = (current - 1) // 2
            if self.elements[current] >= self.elements[parent]:
                break
            self._swap(current, parent)
            current = parent
                
    def pop(self):
        """Return the minimum value from the heap and remove it"""
        if not self.elements:
            raise Exception("Cannot pop from an empty heap")
        output = self.elements[0]
        self._swap(0, -1)
        self.elements.pop()
        current = 0
        while 2 * current + 1 < len(self.elements):
            l = 2 * current + 1
            r = 2 * current + 2
            m = l
            if r < len(self.elements) and self.elements[r] < self.elements[l]:
                m = r
            if self.elements[current] <= self.elements[m]:
                break
            self._swap(current, m)
            current = m
        return output

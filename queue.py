# author: Daniel Lozano

class Queue:
    def __init__(self):
        self._queue = []
        self._count = 0
        self._first_element = 0

    def enqueue(self, value):
        self._queue.append(value)
        self._count += 1

    def dequeue(self):
        if self._count > 0:
            self._first_element += 1
            self._count -= 1
        else:
            raise Exception("Empty array")

    def peek(self):
        if self._count > 0:
            return self._queue[self._first_element]
        else:
            raise Exception("Empty array")

    def empty(self):
        return self._count == 0

    def clean(self):
        self._queue = []
        self._count = 0
        self._first_element = 0


# author: Daniel Lozano

class Stack:
    def __init__(self):
        self._stack = []
        self._long = 0
        self._eliminates_values = []
        self._undo = []
        self._sum = 0

    def push(self, value):
        self._sum += value
        self._stack.append(value)
        self._long += 1
        self._undo.append(0)

    def pop(self):
        self._sum -= self._stack[-1]
        self._long -= 1
        self._undo.append(1)
        self._eliminates_values.append(self._stack[-1])
        self._stack.pop()

    def peek(self):
        return self._stack[-1]

    def empty(self):
        return self._long == 0

    def clear(self):
        self._stack = []
        self._long = 0
        self._eliminates_values = []
        self._undo = []

    def undo(self):
        if self._undo[-1] == 0:
            self._sum -= self._stack[-1]
            self._undo.pop()
            self._stack.pop()
            self._long -= 1
        elif self._undo[-1] == 1:
            self._sum += self._eliminates_values[-1]
            self._undo.pop()
            self._stack.append(self._eliminates_values[-1])
            self._eliminates_values.pop()
            self._long += 1

    def get_sum(self):
        return self._sum

    def get_long(self):
        return self._long


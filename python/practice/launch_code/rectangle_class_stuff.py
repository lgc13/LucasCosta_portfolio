import test

class Rectangle:

    def __init__(self, length, width):
        self.l = length
        self.w = width
        self.area = (self.l * self.w)
        self.perimeter = ((self.l * 2) + (self.w * 2))

    def get_area(self):
        print('Area of rectangle is: %d' % self.area)
        return self.area

    def get_perimeter(self):
        print('Perimeter of rectangle is: %d' % self.perimeter)
        return self.perimeter

    def is_a_square(self):
        if self.l == self.w:
            print('This is indeed, a perfect square')
            return True
        else:
            print('This is not a square')
        return False

    def compare_size(self, second_rec):
        if self.area > second_rec.area:
            print('%s is bigger than %s' % ('The first', 'second rectangle'))
            return True
        else:
            print('%s is bigger than %s' % ('The second rectangle', 'first rectangle'))
        return False

r1 = Rectangle(2, 2)
r2 = Rectangle(2, 3)

test.testEqual(r1.get_area(), 2 * 2)
# testEqual(r1.get_perimeter(), (2 + 2 + 2 + 2))
# testEqual(r2.is_a_square(), False)
# testEqual(r2.compare_size(r1), True)

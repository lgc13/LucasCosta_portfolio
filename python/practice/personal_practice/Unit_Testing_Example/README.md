# Python Unit Testing

1. Create your normal file that you want to be tested. Ex: `calc.py`

2. Create a 'test module' to test your file. This MUST BE named `test_filename.py`. In this case: `test_calc.py`

3. Import the unittest module, and the file to be tested, from within the test file.

   (if this is a class being tested, then do it like: `from filename import Classname`)

4. Create a test class that inherits from unittest. Ex: `class TestCalc(unittest.TestCase)`

5. The methods MUST begin with `test`, but DON'T HAVE TO have the method name. Good examples: `def test_methodname(self)`. Ex: `def test_add(self)`

   You can now use the Unittest assert methods from here:
   https://docs.python.org/3/library/unittest.html#unittest.TestCase.debug

   Ex: `self.assertEqual(calc.add(1, 2), 3)`

6. Add main function call to the test file:

```python
if __name__ == "__main__":
  unittest.main()
```

7. Make sure you are in the right environment, or using the correct python version (2 vs 3)

8. Run tests from terminal with `python test_filename.py`

9. You can use the `def setUp(self):` and the `def tearDown(self):` functions in the beginning of class tests to stay DRY

   You can now create multiple 'edge case' tests. Ex: adding negative numbers, dividing by a negative or 0, passing in incorrect amount of parameters, etc.

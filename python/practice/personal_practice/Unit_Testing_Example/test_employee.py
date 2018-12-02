import unittest
from unittest.mock import patch
from employee import Employee

class TestEmployee(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        print("setUpClass")

    @classmethod
    def tearDownClass(cls):
        print("tearDownClass")

    def setUp(self):
        self.emp1 = Employee("Lucas", "Costa", 10)
        self.emp2 = Employee("Sasha", "Larson", 15)

    def tearDown(self):
        pass

    def test_email(self):
        self.assertEqual(self.emp1.email, "Lucas.Costa@email.com")
        self.assertEqual(self.emp2.email, "Sasha.Larson@email.com")

        self.emp1.first = "Chris"
        self.emp2.first = "Victor"

        self.assertEqual(self.emp1.email, "Chris.Costa@email.com")
        self.assertEqual(self.emp2.email, "Victor.Larson@email.com")

    def test_fullname(self):
        self.assertEqual(self.emp1.fullname, "Lucas Costa")
        self.assertEqual(self.emp2.fullname, "Sasha Larson")

        self.emp1.last = "Galvis"
        self.emp2.first = "Kirk"

        self.assertEqual(self.emp1.fullname, "Lucas Galvis")
        self.assertEqual(self.emp2.fullname, "Kirk Larson")

    def test_apply_raise(self):
        self.emp1.apply_raise()
        self.emp2.apply_raise()

        self.assertEqual(self.emp1.pay, 50)
        self.assertEqual(self.emp2.pay, 75)

    def test_monthly_schedule(self):
        with patch('employee.requests.get') as mocked_get:
            mocked_get.return_value.ok = True
            mocked_get.return_value.text = "It worked"

            schedule = self.emp1.monthly_schedule("December")
            mocked_get.assert_called_with('http://company.com/Costa/December')
            self.assertEqual(schedule, 'It worked') # checks the response

            mocked_get.return_value.ok = False

            schedule = self.emp2.monthly_schedule("June")
            mocked_get.assert_called_with('http://company.com/Larson/June')
            self.assertEqual(schedule, 'Bad response!') # checks the response

if __name__ == "__main__":
    unittest.main()

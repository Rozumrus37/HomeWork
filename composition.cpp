#include <iostream>

using namespace std;

template<typename t>
t f1(t x) {
    return x*x + 1;
}
template<typename t>
t g1(t x) {
    return x + 1;
}

template<class t>
class functionn {
private:
    t value;
public:
    functionn(t value = 0.0f) {
        this->value = value;
    }

    functionn operator *(functionn obj) {
        functionn  result;
        result.value = g1(f1(obj.value));
        return result;
    }
    void print() {
        cout << value << endl;
    }
};


int main() {
    int x;
    std::cin >> x;
    functionn<double> fun1(x);
    functionn<double>  fun2(x);
    functionn<double> res = fun1 * fun2;
    res.print();

    return 0;
}

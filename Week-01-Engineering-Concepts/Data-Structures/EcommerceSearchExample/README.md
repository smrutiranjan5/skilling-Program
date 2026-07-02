# Exercise 2 - E-commerce Platform Search Function

## Objective

Develop a search functionality for an e-commerce platform using Linear Search and Binary Search algorithms and compare their performance.

---

## Scenario

An e-commerce platform contains a list of products. Users search for products using the product name. To improve search performance, two searching techniques are implemented:

- Linear Search
- Binary Search

---

## Concepts Used

- Big O Notation
- Linear Search
- Binary Search
- Arrays
- Object-Oriented Programming (Class & Objects)

---

## Product Attributes

Each product contains:

- Product ID
- Product Name
- Category

---

## Algorithms

### Linear Search

1. Start from the first product.
2. Compare each product name with the search key.
3. Stop when the product is found.
4. If the end of the array is reached, the product is not found.

---

### Binary Search

1. Store products in sorted order.
2. Find the middle product.
3. Compare the middle product with the search key.
4. Search the left half or right half depending on the comparison.
5. Continue until the product is found.

---

## Time Complexity

| Algorithm | Best Case | Average Case | Worst Case |
|-----------|-----------|--------------|-------------|
| Linear Search | O(1) | O(n) | O(n) |
| Binary Search | O(1) | O(log n) | O(log n) |

---

## Comparison

### Linear Search

Advantages:
- Simple to implement.
- No need to sort the data.

Disadvantages:
- Slow for large datasets.

---

### Binary Search

Advantages:
- Much faster for large datasets.
- Efficient searching.

Disadvantages:
- Requires sorted data.

---

## Conclusion

For an e-commerce platform containing thousands or millions of products, **Binary Search** is more suitable because it significantly reduces the search time compared to Linear Search.

Linear Search is useful only for small or unsorted datasets.

---

## Output

See the **Screenshot** folder for the program output.
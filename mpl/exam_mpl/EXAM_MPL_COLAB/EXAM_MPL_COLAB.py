import matplotlib.pyplot as plt
import random

# X-axis values
x = list(range(1, 13))  # 1 to 12

# Y-axis values (random integers between 0 and 100)
y = [random.randint(0, 100) for _ in x]

# Create the bar chart
plt.bar(x, y, color='skyblue')

# Add labels and title
plt.xlabel("Month")
plt.ylabel("Value")
plt.title("Random Bar Chart with 12 Bars")

# Show the chart
plt.show()


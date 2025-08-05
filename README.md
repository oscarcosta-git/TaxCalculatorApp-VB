# 💼 Year 11 Software Design & Development – 2023  
## 🧾 Tax Calculator (VB.NET Windows Forms App)

This project was created as part of my Year 11 Software Design & Development course in 2023. It is a VB.NET Windows Forms application that allows users to input employee names and gross incomes, then calculates the applicable tax and net income based on Australian tax brackets.

---

## 🎯 Features

- Input up to 20 employee records
- Calculate tax and net income
- Display all employee records in a readable format
- Reset all data
- Basic error handling and input validation

---

## 📸 Screenshots

<img src="https://r2.fivemanage.com/image/SFKgKEaOXsMY.png" width="400"/>  
<img src="https://r2.fivemanage.com/image/dFcAucjHkbfR.png" width="400"/>  
<img src="https://r2.fivemanage.com/image/Dsh35JzxPOC8.png" width="400"/>  
<img src="https://r2.fivemanage.com/image/NRarloYj0pFU.png" width="400"/>  

---

## 🧠 How It Works

1. **Input Name and Gross Income**  
2. **Click Calculate**  
   - Tax is calculated using the Australian tax brackets
   - Net income = Gross Income - Tax  
3. **Click Display**  
   - Shows all stored employee tax info
4. **Reset All** clears the memory for a new session

---

## 🧑‍💻 Code Sample

```vb.net
If grossIncome <= 18200 Then
    tax = 0
ElseIf grossIncome <= 45000 Then
    tax = (grossIncome - 18200) * 0.19
ElseIf grossIncome <= 120000 Then
    tax = 5092 + (grossIncome - 45000) * 0.325
ElseIf grossIncome <= 180000 Then
    tax = 29467 + (grossIncome - 120000) * 0.37
Else
    tax = 51667 + (grossIncome - 180000) * 0.45
End If

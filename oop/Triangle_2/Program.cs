# lib1.py

def checkTriangle(a, b, c):
    """
    Verilen üç kenar uzunluğunun bir üçgen oluşturup oluşturmadığını kontrol eder.
    
    Üçgen eşitsizliği kuralı:
    - Her iki kenarın toplamı üçüncü kenardan büyük olmalıdır
    
    Args:
        a, b, c: Üçgenin kenar uzunlukları
        
    Returns:
        bool: Geçerli bir üçgen oluşturuyorsa True, aksi halde False
    """
    # Kenar uzunlukları pozitif olmalı
    if a <= 0 or b <= 0 or c <= 0:
        return False

    # Üçgen eşitsizliği kontrolü
    if (a + b > c) and(a + c > b) and(b + c > a):
        return True
    else:
        return False
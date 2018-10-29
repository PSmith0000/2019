import random
import base64
import math
import binascii

char_set = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+?=<>,.-\"\': "
Coefficient = 31.6
_Key = ""
CRC32_LAST = ""

def createkey():
    _list = list(char_set)
    random.shuffle(_list)
    return ''.join(_list)


def encrypt(text):
    _Data = list()
    _TxtList = list(text)
    _Key = createkey()
    for char in _TxtList:
        char_code = _Key.index(char)
        expression = round(pow(char_code, 2) / Coefficient)
        _Data.append(expression)

    return (_Key, base64.standard_b64encode(bytearray(_Data)))


def decrypt(Text, Secret):
    _Data = list(base64.standard_b64decode(Text))
    _Txt = ""
    _iter = iter(_Data)
    current = 0
    while current < len(_Data):
        code = round(math.sqrt(next(_iter) * Coefficient))
        print(Secret[code])
        current += 1

en = encrypt("Hello!")
decrypt(en[1], en[0])

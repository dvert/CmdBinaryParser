# CmdBinaryParser

Консольное приложение, получающее на вход бинарный файл данного вида: 0x0A, 0x00, 0x20, 0xFF. <br />
На выходе обратный порядок: 0xFF, 0x20, 0x00, 0x0A.<br /><br />

Функционал:
- создание результирующего файла
- запись содержимого в обратном порядке (побайтно)
- имена входного и выходного файлов передаваются через параметры командной строки

import sys
import datetime
import subprocess

# Git передає шлях до тимчасового файлу коміту як перший аргумент
commit_msg_filepath = sys.argv[1]

# Отримуємо поточний час
current_time = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")

# Автоматично дістаємо ім'я автора з локального Git
try:
    author_name = subprocess.check_output(['git', 'config', 'user.name']).decode('utf-8').strip()
except Exception:
    author_name = "Розробник" # Запасний варіант, якщо Git не віддасть ім'я

# Дописуємо підпис у кінець файлу
with open(commit_msg_filepath, 'a', encoding='utf-8') as f:
    f.write(f"\n\n# Розробник: {author_name} | Час: {current_time}\n")

    
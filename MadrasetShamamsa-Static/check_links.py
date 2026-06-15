import os, re
from pathlib import Path
root = Path('.')
html_files = [p for p in root.rglob('*.html')]
print(f'Total HTML files: {len(html_files)}')
all_targets=set()
for p in html_files:
    try:
        text=p.read_text(encoding='utf-8')
    except Exception as e:
        print('READ ERROR', p, e)
        continue
    for href in re.findall(r'href=["\']([^"\']+)["\']', text):
        if href.startswith(('http:','https:','#','mailto:','javascript:')):
            continue
        all_targets.add((p, href))
missing=[]
for p,target in sorted(all_targets, key=lambda x:(str(x[0]), x[1])):
    if target.startswith('/'):
        tar=root/target.lstrip('/')
    else:
        tar=(p.parent / target).resolve()
    tar_path=str(tar).split('#')[0].split('?')[0]
    if tar_path.endswith('.html') and not os.path.exists(tar_path):
        missing.append((p,target,tar_path))
print('Missing target count:', len(missing))
for p,target,tar in missing[:200]:
    print(str(p), '->', target, '=>', tar)

import os;
import shutil;

name = "BryanTabor.Utilities.ArgConvert.1.0.0.nupkg"

src = "%s\\bin\\Debug\\%s"%(os.getcwd(),name);
dst = "B:\\nuget\\%s"%name;

if os.path.exists(dst):
    os.remove(dst)
shutil.copyfile(src, dst);

print("done");
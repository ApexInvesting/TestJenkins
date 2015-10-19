require 'albacore'

msbuild :msbuild do |b|
    b.properties = { :configuration => :Debug }
    b.targets = [ :Build ]
    b.solution = "TestJenkins.sln"
end
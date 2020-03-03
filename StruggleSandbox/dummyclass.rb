class Thing
  attr_accessor :value, :next_thing

  def initialize(value, next_thing = nil)
    @value = value
    @@next_thing = next_thing
  end
end

#--------------------------------------------------------------------------------------------#

class GroupOfThings
  attr_reader :number_of_things

  def initialize
    @number_of_things = 0
    @new_thing = new_thing = nil
    @following_thing = following_thing = nil
  end
  
#  def addThing(value)
#    p new_thing = Thing.new(value)
#    puts "A new thing was added: #{value}"
#    p "Thing count = #{thing_count}"
#    p "New_thing = #{new_thing.value}"
#    p next_thing = new_thing
#    p "Next_thing = #{next_thing.value}"
#    p "New_thing = #{new_thing.value}"
#    return @next_thing
#  end
  
def addThing(value)
  if @new_thing == nil
    puts "########################################################"
    p @new_thing = Thing.new(value, next_thing = nil)
    puts "A new thing was added: #{value}"

    p "Thing count = #{thing_count}"
    p "New_thing = #{@new_thing}"
    p "Next_thing = #{@following_thing}"

    p @new_thing = Thing.instance_variable_set(:@value, @new_thing)
    #p @following_thing = @new_thing 
   #Not sure how to reference a previous instance from a current one

    p "Next_thing = #{@following_thing}"
    puts "IF CLAUSE PRINTED"
    puts "########################################################"

  else 
    puts "########################################################"
    p "New_thing = #{@new_thing.value}"

    p @new_thing = Thing.new(value)
    puts "A new thing was added: #{value}"

    p "Next_thing = #{@following_thing}"

    p @new_thing = Thing.instance_variable_set(:@value, @new_thing)
    #p @following_thing = @new_thing

    p "Thing count = #{thing_count}"
    p "Next_thing = #{@following_thing}"
    p "New_thing = #{@new_thing}"
    puts "ELSE CLAUSE PRINTED"
    puts "########################################################"

  end
end
  

  def thing_count
    @number_of_things += 1
  end

  def getThing(index)    
  end
end 
################################################################################################
################################################################################################
#---> TESTING <---#
p a = GroupOfThings.new
puts""
a.addThing("Cat")
puts ""
a.addThing("Dog")
puts""
a.addThing("Fish")
puts ""
a.addThing("Tiger")

puts "\nGROUP OF THINGS:"
pp a
a.getThing(0)


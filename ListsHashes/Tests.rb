require "test/unit"
Dir['*.rb'].select { |file| !(file.end_with? "Tests.rb") }.each { |file| require_relative file }

class LinkedListTests < Test::Unit::TestCase
    @@linkedListType = ObjectSpace.each_object(Class).find { |c| c < LinkedListInterface }

    def test_count_empty
        list = @@linkedListType.new

        assert_equal(list.count, 0)        
    end
    
    def test_first_value_empty
        list = @@linkedListType.new

        assert_equal(list.first_value, nil)
    end
    
    def test_next_element_empty
        list = @@linkedListType.new

        assert_equal(list.next_element, nil)
    end

    def test_add_value_empty
        list = @@linkedListType.new

        list.add_value(1)
    end

    def test_add_value
        list = @@linkedListType.new

        list.add_value("value")

        assert_equal(list.first_value, "value")
        assert_equal(list.count, 1)
        assert_equal(list.next_element, nil)
    end

    def test_add_twice
        list = @@linkedListType.new

        list.add_value("value")

        assert_equal(list.first_value, "value")
        assert_equal(list.count, 1)
        assert_equal(list.next_element, nil)

        list.add_value("value2")

        assert_equal(list.first_value, "value")
        assert_equal(list.count, 2)
        assert_equal(list.next_element, nil)

        nextElement = list.next_element

        assert_equal(nextElement.first_value, "value2")
        assert_equal(nextElement.count, 1)
        assert_equal(nextElement.next_element, nil)

        assert_equal(list.last_value, nextElement.first_value)
    end

    def test_remove
        list = @@linkedListType.new

        list.add_value("value1")
        list.add_value("value2")
        list.add_value("value3")

        list.remove_value(1)

        assert_equal(list.count, 2)
        assert_equal(list.first_value, "value1")
        assert_equal(list.last_value, "value3")
    end
end